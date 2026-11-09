# Fact 9ad25024

Store id: 6effb218-75d6-4ce7-88fc-8ca8a5da3fa5

## Text

```text
def get_reverse_path_info(self, filtered_relation=None)
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
- posted_at: `2026-11-09T22:39:44.3548590+00:00`

## Data

```json
{
  "end_line": 925,
  "entity_kind": "method",
  "parent": "ForeignObject",
  "start_line": 911,
  "symbol": "ForeignObject.get_reverse_path_info"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/related.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":911,"selector":"L911-L925","symbol":"ForeignObject.get_reverse_path_info"}`

## Items

```json
[
  {
    "text": "Get path from the related model to this field's model.",
    "locator": {
      "line": 912
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/fields/related::ForeignObject.get_reverse_path_info](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 925,
    "entity_kind": "method",
    "parent": "ForeignObject",
    "start_line": 911,
    "symbol": "ForeignObject.get_reverse_path_info"
  },
  "id": "6effb218-75d6-4ce7-88fc-8ca8a5da3fa5",
  "items": [
    {
      "locator": {
        "line": 912
      },
      "text": "Get path from the related model to this field's model."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:44.3548590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 911,
        "selector": "L911-L925",
        "symbol": "ForeignObject.get_reverse_path_info"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/related.py"
    }
  ],
  "status": "live",
  "subject_id": "e71622e8-b065-4594-bb32-7d8d080d980b",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_reverse_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_reverse_path_info(self, filtered_relation=None)"
}
```
