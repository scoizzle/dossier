# Fact d4f37cb4

Store id: c602169b-d9c5-47aa-9200-bd873085f03d

## Text

```text
def one_to_many(self)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:cached_property`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:52.4515370+00:00`

## Data

```json
{
  "end_line": 109,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 107,
  "symbol": "ForeignObjectRel.one_to_many"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":107,"selector":"L107-L109","symbol":"ForeignObjectRel.one_to_many"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.one_to_many](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 109,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 107,
    "symbol": "ForeignObjectRel.one_to_many"
  },
  "id": "c602169b-d9c5-47aa-9200-bd873085f03d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4515370+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 107,
        "selector": "L107-L109",
        "symbol": "ForeignObjectRel.one_to_many"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "a553ec16-1c05-453e-a18c-81c549b86b24",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.one_to_many",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def one_to_many(self)"
}
```
