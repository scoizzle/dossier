# Fact 4df3fa49

Store id: 08509f71-7af4-4e4b-a681-14a8e377d833

## Text

```text
def one_to_one(self)
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
- posted_at: `2026-11-09T23:32:00.2554540+00:00`

## Data

```json
{
  "end_line": 113,
  "entity_kind": "method",
  "parent": "ForeignObjectRel",
  "start_line": 111,
  "symbol": "ForeignObjectRel.one_to_one"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/reverse_related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":111,"selector":"L111-L113","symbol":"ForeignObjectRel.one_to_one"}`

## Referenced by

None.

## Subject

[django/db/models/fields/reverse_related::ForeignObjectRel.one_to_one](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 113,
    "entity_kind": "method",
    "parent": "ForeignObjectRel",
    "start_line": 111,
    "symbol": "ForeignObjectRel.one_to_one"
  },
  "id": "08509f71-7af4-4e4b-a681-14a8e377d833",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2554540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 111,
        "selector": "L111-L113",
        "symbol": "ForeignObjectRel.one_to_one"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/reverse_related.py"
    }
  ],
  "status": "live",
  "subject_id": "f9cc8774-b319-4c24-83f9-5a5ac81e3827",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.one_to_one",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def one_to_one(self)"
}
```
