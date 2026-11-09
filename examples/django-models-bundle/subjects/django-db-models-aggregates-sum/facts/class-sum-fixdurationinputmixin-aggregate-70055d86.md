# Fact 70055d86

Store id: 152e6992-25a3-4af1-918f-6ab63eefa3b0

## Text

```text
class Sum(FixDurationInputMixin, Aggregate)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:48.4061790+00:00`

## Data

```json
{
  "end_line": 456,
  "entity_kind": "class",
  "parent": "aggregates",
  "start_line": 452,
  "symbol": "Sum"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/aggregates.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":452,"selector":"L452-L456","symbol":"Sum"}`

## Referenced by

None.

## Subject

[django/db/models/aggregates::Sum](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 456,
    "entity_kind": "class",
    "parent": "aggregates",
    "start_line": 452,
    "symbol": "Sum"
  },
  "id": "152e6992-25a3-4af1-918f-6ab63eefa3b0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:48.4061790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 452,
        "selector": "L452-L456",
        "symbol": "Sum"
      },
      "rel": "derived_from",
      "target": "django/db/models/aggregates.py"
    }
  ],
  "status": "live",
  "subject_id": "8254f144-f006-48a7-bf61-9c1e979341f9",
  "subject_name": "django/db/models/aggregates::Sum",
  "tags": [
    "entity:class"
  ],
  "text": "class Sum(FixDurationInputMixin, Aggregate)"
}
```
