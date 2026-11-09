# Fact 8d68a1f6

Store id: 7608a03b-660e-4f27-a2ec-8ddb941f3160

## Text

```text
def bitrightshift(self, other)
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
- posted_at: `2026-11-09T23:44:49.2481610+00:00`

## Data

```json
{
  "end_line": 111,
  "entity_kind": "method",
  "parent": "Combinable",
  "start_line": 110,
  "symbol": "Combinable.bitrightshift"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":110,"selector":"L110-L111","symbol":"Combinable.bitrightshift"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Combinable.bitrightshift](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 111,
    "entity_kind": "method",
    "parent": "Combinable",
    "start_line": 110,
    "symbol": "Combinable.bitrightshift"
  },
  "id": "7608a03b-660e-4f27-a2ec-8ddb941f3160",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.2481610+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 110,
        "selector": "L110-L111",
        "symbol": "Combinable.bitrightshift"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "5eab9b20-8ab1-41c8-b7d0-599c17bfcc9a",
  "subject_name": "django/db/models/expressions::Combinable.bitrightshift",
  "tags": [
    "entity:method"
  ],
  "text": "def bitrightshift(self, other)"
}
```
