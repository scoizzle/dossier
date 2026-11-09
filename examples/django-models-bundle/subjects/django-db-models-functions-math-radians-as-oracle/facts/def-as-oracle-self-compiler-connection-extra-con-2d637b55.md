# Fact 2d637b55

Store id: 42375811-c353-4b0b-b37e-066214e54398

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
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
- posted_at: `2026-11-09T23:32:01.7386840+00:00`

## Data

```json
{
  "end_line": 156,
  "entity_kind": "method",
  "parent": "Radians",
  "start_line": 150,
  "symbol": "Radians.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":150,"selector":"L150-L156","symbol":"Radians.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Radians.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 156,
    "entity_kind": "method",
    "parent": "Radians",
    "start_line": 150,
    "symbol": "Radians.as_oracle"
  },
  "id": "42375811-c353-4b0b-b37e-066214e54398",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7386840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 150,
        "selector": "L150-L156",
        "symbol": "Radians.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "83445444-1273-4dd0-83d4-8aa32acf0e10",
  "subject_name": "django/db/models/functions/math::Radians.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
