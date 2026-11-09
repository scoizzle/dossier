# Fact 4e3c8761

Store id: c1c182aa-692d-4fb6-9ea9-cd7c6994ef57

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
- posted_at: `2026-11-09T23:44:49.4446680+00:00`

## Data

```json
{
  "end_line": 762,
  "entity_kind": "method",
  "parent": "CombinedExpression",
  "start_line": 747,
  "symbol": "CombinedExpression._resolve_output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":747,"selector":"L747-L762","symbol":"CombinedExpression._resolve_output_field"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::CombinedExpression._resolve_output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 762,
    "entity_kind": "method",
    "parent": "CombinedExpression",
    "start_line": 747,
    "symbol": "CombinedExpression._resolve_output_field"
  },
  "id": "c1c182aa-692d-4fb6-9ea9-cd7c6994ef57",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4446680+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 747,
        "selector": "L747-L762",
        "symbol": "CombinedExpression._resolve_output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "614fa331-3179-4d1e-adc0-775a83177133",
  "subject_name": "django/db/models/expressions::CombinedExpression._resolve_output_field",
  "tags": [
    "entity:method"
  ],
  "text": "def _resolve_output_field(self)"
}
```
