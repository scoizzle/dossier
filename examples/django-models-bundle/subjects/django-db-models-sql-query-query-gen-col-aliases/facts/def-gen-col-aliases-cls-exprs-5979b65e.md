# Fact 5979b65e

Store id: 9762a9e5-72ed-4c79-9964-5b51721797ea

## Text

```text
def _gen_col_aliases(cls, exprs)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class_method`, `decorator:classmethod`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:06.9910580+00:00`

## Data

```json
{
  "end_line": 2059,
  "entity_kind": "class_method",
  "parent": "Query",
  "start_line": 2057,
  "symbol": "Query._gen_col_aliases"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2057,"selector":"L2057-L2059","symbol":"Query._gen_col_aliases"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query._gen_col_aliases](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2059,
    "entity_kind": "class_method",
    "parent": "Query",
    "start_line": 2057,
    "symbol": "Query._gen_col_aliases"
  },
  "id": "9762a9e5-72ed-4c79-9964-5b51721797ea",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.9910580+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2057,
        "selector": "L2057-L2059",
        "symbol": "Query._gen_col_aliases"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "a71524ff-be5f-4e7e-9387-80ac9ef7300a",
  "subject_name": "django/db/models/sql/query::Query._gen_col_aliases",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _gen_col_aliases(cls, exprs)"
}
```
