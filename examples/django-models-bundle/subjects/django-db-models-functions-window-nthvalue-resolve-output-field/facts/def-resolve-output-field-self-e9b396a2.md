# Fact e9b396a2

Store id: a34be352-8eb6-48e7-8796-1146fbe83bf4

## Text

```text
def _resolve_output_field(self)
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
- posted_at: `2026-11-09T23:44:54.4962050+00:00`

## Data

```json
{
  "end_line": 91,
  "entity_kind": "method",
  "parent": "NthValue",
  "start_line": 89,
  "symbol": "NthValue._resolve_output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/window.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":89,"selector":"L89-L91","symbol":"NthValue._resolve_output_field"}`

## Referenced by

None.

## Subject

[django/db/models/functions/window::NthValue._resolve_output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 91,
    "entity_kind": "method",
    "parent": "NthValue",
    "start_line": 89,
    "symbol": "NthValue._resolve_output_field"
  },
  "id": "a34be352-8eb6-48e7-8796-1146fbe83bf4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.4962050+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 89,
        "selector": "L89-L91",
        "symbol": "NthValue._resolve_output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/window.py"
    }
  ],
  "status": "live",
  "subject_id": "3da631a8-2efe-46a9-bf53-3cafc7ea6e5f",
  "subject_name": "django/db/models/functions/window::NthValue._resolve_output_field",
  "tags": [
    "entity:method"
  ],
  "text": "def _resolve_output_field(self)"
}
```
