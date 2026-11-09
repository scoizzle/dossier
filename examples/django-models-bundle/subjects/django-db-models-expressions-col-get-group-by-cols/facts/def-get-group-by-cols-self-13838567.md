# Fact 13838567

Store id: 071e0c86-9280-452f-8a08-6d68b6dc91cc

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
- posted_at: `2026-11-09T22:39:41.6343260+00:00`

## Data

```json
{
  "end_line": 1380,
  "entity_kind": "method",
  "parent": "Col",
  "start_line": 1379,
  "symbol": "Col.get_group_by_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1379,"selector":"L1379-L1380","symbol":"Col.get_group_by_cols"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Col.get_group_by_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1380,
    "entity_kind": "method",
    "parent": "Col",
    "start_line": 1379,
    "symbol": "Col.get_group_by_cols"
  },
  "id": "071e0c86-9280-452f-8a08-6d68b6dc91cc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6343260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1379,
        "selector": "L1379-L1380",
        "symbol": "Col.get_group_by_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "e4b02c89-ac82-468f-8391-42b9417757e5",
  "subject_name": "django/db/models/expressions::Col.get_group_by_cols",
  "tags": [
    "entity:method"
  ],
  "text": "def get_group_by_cols(self)"
}
```
