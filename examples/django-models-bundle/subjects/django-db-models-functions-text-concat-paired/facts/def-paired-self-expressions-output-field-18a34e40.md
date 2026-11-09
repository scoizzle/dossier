# Fact 18a34e40

Store id: bcdc1239-bd11-40ce-9f97-e509da8957f0

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
- posted_at: `2026-11-09T23:44:54.0800570+00:00`

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
  "id": "bcdc1239-bd11-40ce-9f97-e509da8957f0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.0800570+00:00"
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
  "subject_id": "bff39322-637b-4fe3-963d-8121c2c8b431",
  "subject_name": "django/db/models/functions/text::Concat._paired",
  "tags": [
    "entity:method"
  ],
  "text": "def _paired(self, expressions, output_field)"
}
```
