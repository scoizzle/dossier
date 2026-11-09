# Fact 04b7b908

Store id: 30790332-a06c-4596-ade6-6fa50922e3fc

## Text

```text
def reverse_related_fields(self)
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
- posted_at: `2026-11-09T23:44:51.5292330+00:00`

## Data

```json
{
  "end_line": 812,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 810,
  "symbol": "ForeignObject.reverse_related_fields"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":810,"selector":"L810-L812","symbol":"ForeignObject.reverse_related_fields"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.reverse_related_fields](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 812,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 810,
    "symbol": "ForeignObject.reverse_related_fields"
  },
  "id": "30790332-a06c-4596-ade6-6fa50922e3fc",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:51.5292330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 810,
        "selector": "L810-L812",
        "symbol": "ForeignObject.reverse_related_fields"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "2d715046-26d0-4c2f-90ca-900f9f1c09be",
  "subject_name": "django/db/models/fields/related::ForeignObject.reverse_related_fields",
  "tags": [
    "entity:method",
    "decorator:cached_property"
  ],
  "text": "def reverse_related_fields(self)"
}
```
