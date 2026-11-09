# Fact 5c5ca401

Store id: 512e12a6-b2d2-475c-b373-66dbbc4fa3bf

## Text

```text
def non_db_attrs(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:44.3112800+00:00`

## Data

```json
{
  "end_line": 610,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 604,
  "symbol": "ForeignObject.non_db_attrs"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":604,"selector":"L604-L610","symbol":"ForeignObject.non_db_attrs"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.non_db_attrs](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 610,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 604,
    "symbol": "ForeignObject.non_db_attrs"
  },
  "id": "512e12a6-b2d2-475c-b373-66dbbc4fa3bf",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3112800+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 604,
        "selector": "L604-L610",
        "symbol": "ForeignObject.non_db_attrs"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "8371b3d0-ff26-4633-80bc-597bf449c8af",
  "subject_name": "django/db/models/fields/related::ForeignObject.non_db_attrs",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def non_db_attrs(self)"
}
```
