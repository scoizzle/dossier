# Fact 6bccd449

Store id: 6364e0ec-2118-4c1d-91fb-6cd936543ae4

## Text

```text
class ForeignKeyDeferredAttribute(DeferredAttribute)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:51.8036470+00:00`

## Data

```json
{
  "end_line": 93,
  "entity_kind": "class",
  "parent": "related_descriptors",
  "start_line": 87,
  "symbol": "ForeignKeyDeferredAttribute"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related_descriptors.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":87,"selector":"L87-L93","symbol":"ForeignKeyDeferredAttribute"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related_descriptors::ForeignKeyDeferredAttribute](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 93,
    "entity_kind": "class",
    "parent": "related_descriptors",
    "start_line": 87,
    "symbol": "ForeignKeyDeferredAttribute"
  },
  "id": "6364e0ec-2118-4c1d-91fb-6cd936543ae4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.8036470+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 87,
        "selector": "L87-L93",
        "symbol": "ForeignKeyDeferredAttribute"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related_descriptors.py"
    }
  ],
  "status": "live",
  "subject_id": "4cb24a19-0805-4510-8588-ddb104d5ad7d",
  "subject_name": "django/db/models/fields/related_descriptors::ForeignKeyDeferredAttribute",
  "tags": [
    "entity:class"
  ],
  "text": "class ForeignKeyDeferredAttribute(DeferredAttribute)"
}
```
