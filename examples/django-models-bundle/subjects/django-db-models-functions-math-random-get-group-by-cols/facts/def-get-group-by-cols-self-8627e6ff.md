# Fact 8627e6ff

Store id: 2cb81d7c-b8ca-4d11-bb0d-7fd4fb25fd24

## Text

```text
def get_group_by_cols(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:53.7592440+00:00`

## Data

```json
{
  "end_line": 175,
  "entity_kind": "method",
  "parent": "Random",
  "start_line": 174,
  "symbol": "Random.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":174,"selector":"L174-L175","symbol":"Random.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Random.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 175,
    "entity_kind": "method",
    "parent": "Random",
    "start_line": 174,
    "symbol": "Random.get_group_by_cols"
  },
  "id": "2cb81d7c-b8ca-4d11-bb0d-7fd4fb25fd24",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7592440+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 174,
        "selector": "L174-L175",
        "symbol": "Random.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "819320cf-e6e9-488e-a6c8-eb6d74e551ce",
  "subject_name": "django/db/models/functions/math::Random.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
