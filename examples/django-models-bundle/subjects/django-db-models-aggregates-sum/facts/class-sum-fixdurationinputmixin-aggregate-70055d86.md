# Fact 70055d86

Store id: 75f0b6d5-c70a-4319-9852-69c1205fb9ef

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
- posted_at: `2026-11-09T22:39:40.0488280+00:00`

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
  "id": "75f0b6d5-c70a-4319-9852-69c1205fb9ef",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:40.0488280+00:00"
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
  "subject_id": "d9972ebd-e19c-4cd8-942b-cddda683692f",
  "subject_name": "django/db/models/aggregates::Sum",
  "tags": [
    "entity:class"
  ],
  "text": "class Sum(FixDurationInputMixin, Aggregate)"
}
```
