# Fact 18a34e40

Store id: 838ca47e-8d4b-4e2b-8903-9c573c5c1724

## Text

```text
def _paired(self, expressions, output_field)
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
- posted_at: `2026-11-09T22:39:47.0993110+00:00`

## Data

```json
{
  "end_line": 151,
  "entity_kind": "method",
  "parent": "Concat",
  "start_line": 141,
  "symbol": "Concat._paired"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":141,"selector":"L141-L151","symbol":"Concat._paired"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Concat._paired](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 151,
    "entity_kind": "method",
    "parent": "Concat",
    "start_line": 141,
    "symbol": "Concat._paired"
  },
  "id": "838ca47e-8d4b-4e2b-8903-9c573c5c1724",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.0993110+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 141,
        "selector": "L141-L151",
        "symbol": "Concat._paired"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "e9ea00f8-88d6-4fa4-b922-5b548fe675be",
  "subject_name": "django/db/models/functions/text::Concat._paired",
  "tags": [
    "entity:method"
  ],
  "text": "def _paired(self, expressions, output_field)"
}
```
