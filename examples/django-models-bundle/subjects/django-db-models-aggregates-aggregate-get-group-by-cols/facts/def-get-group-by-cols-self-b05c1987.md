# Fact b05c1987

Store id: 0ab870ba-434b-44d9-ba38-40e3a2a57be7

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
- posted_at: `2026-11-09T23:31:53.5340960+00:00`

## Data

```json
{
  "end_line": 172,
  "entity_kind": "method",
  "parent": "Aggregate",
  "start_line": 171,
  "symbol": "Aggregate.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":171,"selector":"L171-L172","symbol":"Aggregate.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Aggregate.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 172,
    "entity_kind": "method",
    "parent": "Aggregate",
    "start_line": 171,
    "symbol": "Aggregate.get_group_by_cols"
  },
  "id": "0ab870ba-434b-44d9-ba38-40e3a2a57be7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:53.5340960+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 171,
        "selector": "L171-L172",
        "symbol": "Aggregate.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "77955b26-7313-4ea1-b61d-dd24ecee7e91",
  "subject_name": "django/db/models/aggregates::Aggregate.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
