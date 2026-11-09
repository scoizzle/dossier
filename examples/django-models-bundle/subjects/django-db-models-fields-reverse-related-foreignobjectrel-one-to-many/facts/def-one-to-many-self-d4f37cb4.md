# Fact d4f37cb4

Store id: e443318b-848b-403b-bad3-a63bbef04ff1

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
- posted_at: `2026-11-09T23:32:00.2522170+00:00`

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
  "id": "e443318b-848b-403b-bad3-a63bbef04ff1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:00.2522170+00:00"
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
  "subject_id": "67f3dd30-5411-45d4-8b10-b126be6b1337",
  "subject_name": "django/db/models/fields/reverse_related::ForeignObjectRel.one_to_many",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def one_to_many(self)"
}
```
