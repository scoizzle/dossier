# Fact 8627e6ff

Store id: c8621bad-8f66-4f7a-81d6-89b944e93f5c

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
- posted_at: `2026-11-09T23:32:01.7561090+00:00`

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
  "id": "c8621bad-8f66-4f7a-81d6-89b944e93f5c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7561090+00:00"
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
  "subject_id": "d2c9cdf1-a493-49b0-aca1-4ea0951e6142",
  "subject_name": "django/db/models/functions/math::Random.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
