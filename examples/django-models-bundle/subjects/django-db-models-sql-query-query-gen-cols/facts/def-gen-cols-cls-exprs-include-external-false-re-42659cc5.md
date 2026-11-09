# Fact 42659cc5

Store id: 0585c128-d945-4884-8557-2dd4a62a881f

## Text

```text
def _gen_cols(cls, exprs, include_external=False, resolve_refs=True)
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
- posted_at: `2026-11-09T22:39:51.4193630+00:00`

## Data

```json
{
  "end_line": 2055,
  "entity_kind": "class_method",
  "parent": "Query",
  "start_line": 2039,
  "symbol": "Query._gen_cols"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/query.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2039,"selector":"L2039-L2055","symbol":"Query._gen_cols"}`

## Referenced by

None.

## Subject

[django/db/models/sql/query::Query._gen_cols](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2055,
    "entity_kind": "class_method",
    "parent": "Query",
    "start_line": 2039,
    "symbol": "Query._gen_cols"
  },
  "id": "0585c128-d945-4884-8557-2dd4a62a881f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:51.4193630+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2039,
        "selector": "L2039-L2055",
        "symbol": "Query._gen_cols"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/query.py"
    }
  ],
  "status": "live",
  "subject_id": "3377f698-e9a6-487f-8b54-8597f74c230b",
  "subject_name": "django/db/models/sql/query::Query._gen_cols",
  "tags": [
    "entity:class_method",
    "decorator:classmethod"
  ],
  "text": "def _gen_cols(cls, exprs, include_external=False, resolve_refs=True)"
}
```
