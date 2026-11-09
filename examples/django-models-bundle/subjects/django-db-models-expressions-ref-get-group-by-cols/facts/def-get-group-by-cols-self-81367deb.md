# Fact 81367deb

Store id: 3900705b-f3e2-4b9c-9c7d-e7699c2ca2b7

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
- posted_at: `2026-11-09T23:31:55.9234290+00:00`

## Data

```json
{
  "end_line": 1485,
  "entity_kind": "method",
  "parent": "Ref",
  "start_line": 1484,
  "symbol": "Ref.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1484,"selector":"L1484-L1485","symbol":"Ref.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Ref.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1485,
    "entity_kind": "method",
    "parent": "Ref",
    "start_line": 1484,
    "symbol": "Ref.get_group_by_cols"
  },
  "id": "3900705b-f3e2-4b9c-9c7d-e7699c2ca2b7",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.9234290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1484,
        "selector": "L1484-L1485",
        "symbol": "Ref.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "54db1b49-b5c3-4aeb-9ce8-abf2f3e0fa72",
  "subject_name": "django/db/models/expressions::Ref.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
