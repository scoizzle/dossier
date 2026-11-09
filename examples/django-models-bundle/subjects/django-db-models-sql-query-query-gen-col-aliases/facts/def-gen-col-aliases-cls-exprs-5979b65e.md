# Fact 5979b65e

Store id: de7315bb-a32a-4195-b241-121e02809b71

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
- posted_at: `2026-11-09T22:39:51.4232000+00:00`

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
  "id": "de7315bb-a32a-4195-b241-121e02809b71",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4232000+00:00"
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
  "subject_id": "20c35bea-7f29-4199-a60c-dbc04d62eec5",
  "subject_name": "django/db/models/sql/query::Query._gen_col_aliases",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _gen_col_aliases(cls, exprs)"
}
```
