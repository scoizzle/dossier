# Fact 2668da06

Store id: 92fb8c5b-7431-4cb9-a8f8-883edf9aab0b

## Text

```text
def local_related_fields(self)
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
- posted_at: `2026-11-09T23:31:58.6870260+00:00`

## Data

```json
{
  "end_line": 816,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 814,
  "symbol": "ForeignObject.local_related_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":814,"selector":"L814-L816","symbol":"ForeignObject.local_related_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.local_related_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 816,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 814,
    "symbol": "ForeignObject.local_related_fields"
  },
  "id": "92fb8c5b-7431-4cb9-a8f8-883edf9aab0b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6870260+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 814,
        "selector": "L814-L816",
        "symbol": "ForeignObject.local_related_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "d2ce401b-ee02-443c-956c-e58df5258936",
  "subject_name": "django/db/models/fields/related::ForeignObject.local_related_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def local_related_fields(self)"
}
```
