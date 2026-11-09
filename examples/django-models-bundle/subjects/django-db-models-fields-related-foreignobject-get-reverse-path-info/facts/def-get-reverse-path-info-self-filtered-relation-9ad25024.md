# Fact 9ad25024

Store id: 763f0534-c94a-4031-9695-6f256f06d0ef

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
- posted_at: `2026-11-09T23:31:58.7252460+00:00`

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
  "id": "763f0534-c94a-4031-9695-6f256f06d0ef",
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
    "posted_at": "2026-11-09T23:31:58.7252460+00:00"
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
  "subject_id": "17093f64-1975-4ca1-a956-ba90ac1c8d28",
  "subject_name": "django/db/models/fields/related::ForeignObject.get_reverse_path_info",
  "tags": [
    "entity:method"
  ],
  "text": "def get_reverse_path_info(self, filtered_relation=None)"
}
```
