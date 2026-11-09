# Fact e3fb3324

Store id: 24d7c8f7-35ea-466b-be95-884d26d69760

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
- posted_at: `2026-11-09T23:31:56.0010060+00:00`

## Data

```json
{
  "end_line": 2056,
  "entity_kind": "method",
  "parent": "Window",
  "start_line": 2055,
  "symbol": "Window._resolve_output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2055,"selector":"L2055-L2056","symbol":"Window._resolve_output_field"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Window._resolve_output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2056,
    "entity_kind": "method",
    "parent": "Window",
    "start_line": 2055,
    "symbol": "Window._resolve_output_field"
  },
  "id": "24d7c8f7-35ea-466b-be95-884d26d69760",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.0010060+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2055,
        "selector": "L2055-L2056",
        "symbol": "Window._resolve_output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "38e63e2b-a4d2-4a14-9b6f-0a7aa84fd96e",
  "subject_name": "django/db/models/expressions::Window._resolve_output_field",
  "tags": [
    "entity:method"
  ],
  "text": "def _resolve_output_field(self)"
}
```
