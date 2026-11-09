# Fact 9b719def

Store id: 3ef819bd-d170-46fd-b65f-ac33a4807e11

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
- posted_at: `2026-11-09T23:31:55.8636290+00:00`

## Data

```json
{
  "end_line": 1237,
  "entity_kind": "method",
  "parent": "Value",
  "start_line": 1215,
  "symbol": "Value._resolve_output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1215,"selector":"L1215-L1237","symbol":"Value._resolve_output_field"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Value._resolve_output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1237,
    "entity_kind": "method",
    "parent": "Value",
    "start_line": 1215,
    "symbol": "Value._resolve_output_field"
  },
  "id": "3ef819bd-d170-46fd-b65f-ac33a4807e11",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.8636290+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1215,
        "selector": "L1215-L1237",
        "symbol": "Value._resolve_output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "8b9a1c47-62c7-4118-bf46-99a01a803ca7",
  "subject_name": "django/db/models/expressions::Value._resolve_output_field",
  "tags": [
    "entity:method"
  ],
  "text": "def _resolve_output_field(self)"
}
```
