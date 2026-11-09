# Fact feb242f0

Store id: d808bd45-594a-4da0-ba81-0ddc68ceb1a6

## Text

```text
def many_to_one(self)
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
- posted_at: `2026-11-09T23:44:52.4378680+00:00`

## Data

```json
{
  "end_line": 105,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 103,
  "symbol": "ForeignObjectRel.many_to_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":103,"selector":"L103-L105","symbol":"ForeignObjectRel.many_to_one"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.many_to_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 105,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 103,
    "symbol": "ForeignObjectRel.many_to_one"
  },
  "id": "d808bd45-594a-4da0-ba81-0ddc68ceb1a6",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:52.4378680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 103,
        "selector": "L103-L105",
        "symbol": "ForeignObjectRel.many_to_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "d24c4907-2b5b-42c3-b51c-5eafb5695ba0",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.many_to_one",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def many_to_one(self)"
}
```
