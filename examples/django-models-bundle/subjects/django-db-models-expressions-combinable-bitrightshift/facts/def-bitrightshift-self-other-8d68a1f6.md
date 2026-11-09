# Fact 8d68a1f6

Store id: eaf9d4d9-af15-483d-b86e-19bbc5022d66

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
- posted_at: `2026-11-09T23:31:55.7346250+00:00`

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
  "id": "eaf9d4d9-af15-483d-b86e-19bbc5022d66",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7346250+00:00"
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
  "subject_id": "3f7ac6c2-19c8-4e34-aa3f-84fc782ec690",
  "subject_name": "django/db/models/expressions::Combinable.bitrightshift",
  "tags": [
    "entity:method"
  ],
  "text": "def bitrightshift(self, other)"
}
```
