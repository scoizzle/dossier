# Fact 608680a8

Store id: a5852a87-4ab4-4fe2-9c65-74661a7a83d0

## Text

```text
def __set__(self, instance, value)
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
- posted_at: `2026-11-09T22:39:44.6848050+00:00`

## Data

```json
{
  "end_line": 93,
  "entity_kind": "method",
  "parent": "ForeignKeyDeferredAttribute",
  "start_line": 88,
  "symbol": "ForeignKeyDeferredAttribute.__set__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":88,"selector":"L88-L93","symbol":"ForeignKeyDeferredAttribute.__set__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForeignKeyDeferredAttribute.__set__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 93,
    "entity_kind": "method",
    "parent": "ForeignKeyDeferredAttribute",
    "start_line": 88,
    "symbol": "ForeignKeyDeferredAttribute.__set__"
  },
  "id": "a5852a87-4ab4-4fe2-9c65-74661a7a83d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.6848050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 88,
        "selector": "L88-L93",
        "symbol": "ForeignKeyDeferredAttribute.__set__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "bc507cf0-db46-458e-86cc-0f90b9778695",
  "subject_name": "django/db/models/fields/related_descriptors::ForeignKeyDeferredAttribute.__set__",
  "tags": [
    "entity:method"
  ],
  "text": "def __set__(self, instance, value)"
}
```
