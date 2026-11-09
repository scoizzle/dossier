# Fact 8605c4cc

Store id: 20d9fa8c-fad3-449e-9c29-59cff4d3fe8d

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
- posted_at: `2026-11-09T22:39:46.6764540+00:00`

## Data

```json
{
  "end_line": 194,
  "entity_kind": "method",
  "parent": "Round",
  "start_line": 192,
  "symbol": "Round._resolve_output_field"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":192,"selector":"L192-L194","symbol":"Round._resolve_output_field"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Round._resolve_output_field](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 194,
    "entity_kind": "method",
    "parent": "Round",
    "start_line": 192,
    "symbol": "Round._resolve_output_field"
  },
  "id": "20d9fa8c-fad3-449e-9c29-59cff4d3fe8d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6764540+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 192,
        "selector": "L192-L194",
        "symbol": "Round._resolve_output_field"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "c6a1329b-33c7-444d-ad30-d5123597cc9a",
  "subject_name": "django/db/models/functions/math::Round._resolve_output_field",
  "tags": [
    "entity:method"
  ],
  "text": "def _resolve_output_field(self)"
}
```
