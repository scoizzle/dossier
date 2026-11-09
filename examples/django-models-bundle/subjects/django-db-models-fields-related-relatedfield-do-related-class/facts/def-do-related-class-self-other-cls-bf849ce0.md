# Fact bf849ce0

Store id: e35ec587-e092-48d5-aa8b-48d582bacfb4

## Text

```text
def do_related_class(self, other, cls)
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
- posted_at: `2026-11-09T23:31:58.6360330+00:00`

## Data

```json
{
  "end_line": 479,
  "entity_kind": "method",
  "parent": "RelatedField",
  "start_line": 477,
  "symbol": "RelatedField.do_related_class"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":477,"selector":"L477-L479","symbol":"RelatedField.do_related_class"}`

## Referenced by

None.

## Subject

[django/db/models/fields/related::RelatedField.do_related_class](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 479,
    "entity_kind": "method",
    "parent": "RelatedField",
    "start_line": 477,
    "symbol": "RelatedField.do_related_class"
  },
  "id": "e35ec587-e092-48d5-aa8b-48d582bacfb4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:58.6360330+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 477,
        "selector": "L477-L479",
        "symbol": "RelatedField.do_related_class"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "4860f9e8-1892-4a1e-98a8-6a12326e7440",
  "subject_name": "django/db/models/fields/related::RelatedField.do_related_class",
  "tags": [
    "entity:method"
  ],
  "text": "def do_related_class(self, other, cls)"
}
```
