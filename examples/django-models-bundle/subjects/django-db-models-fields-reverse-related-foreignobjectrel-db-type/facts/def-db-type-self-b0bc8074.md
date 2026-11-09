# Fact b0bc8074

Store id: a92c4da9-69bd-4a8b-ac80-6b68ac660c6e

## Text

```text
def db_type(self)
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
- posted_at: `2026-11-09T22:39:45.3297530+00:00`

## Data

```json
{
  "end_line": 129,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 127,
  "symbol": "ForeignObjectRel.db_type"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":127,"selector":"L127-L129","symbol":"ForeignObjectRel.db_type"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.db_type](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 129,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 127,
    "symbol": "ForeignObjectRel.db_type"
  },
  "id": "a92c4da9-69bd-4a8b-ac80-6b68ac660c6e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:45.3297530+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 127,
        "selector": "L127-L129",
        "symbol": "ForeignObjectRel.db_type"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "88b8c1ef-9d8a-47a4-8f37-08751456db44",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.db_type",
  "tags": [
    "entity:method",
    "decorator:property"
  ],
  "text": "def db_type(self)"
}
```
