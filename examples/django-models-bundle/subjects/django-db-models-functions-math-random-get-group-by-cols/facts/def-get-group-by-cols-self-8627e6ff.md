# Fact 8627e6ff

Store id: 901543c7-2de3-45e4-a970-aca4bfd9c78c

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
- posted_at: `2026-11-09T22:39:46.6653820+00:00`

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
  "id": "901543c7-2de3-45e4-a970-aca4bfd9c78c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6653820+00:00"
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
  "subject_id": "7170b99d-08a7-470e-a4a6-de5426201022",
  "subject_name": "django/db/models/functions/math::Random.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
