# Fact 41219c2a

Store id: 8cd8ebde-b494-4d18-a254-873a2523977e

## Text

```text
class IntegerLessThanOrEqual(IntegerFieldOverflow, LessThanOrEqual)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:IntegerField.register_lookup`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:03.3146790+00:00`

## Data

```json
{
  "end_line": 499,
  "entity_kind": "class",
  "parent": "lookups",
  "start_line": 497,
  "symbol": "IntegerLessThanOrEqual"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":497,"selector":"L497-L499","symbol":"IntegerLessThanOrEqual"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::IntegerLessThanOrEqual](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 499,
    "entity_kind": "class",
    "parent": "lookups",
    "start_line": 497,
    "symbol": "IntegerLessThanOrEqual"
  },
  "id": "8cd8ebde-b494-4d18-a254-873a2523977e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:03.3146790+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 497,
        "selector": "L497-L499",
        "symbol": "IntegerLessThanOrEqual"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "1f0431d3-930e-412e-b7a5-841eab03c89e",
  "subject_name": "django/db/models/lookups::IntegerLessThanOrEqual",
  "tags": [
    "entity:class",
    "decorator:IntegerField.register_lookup"
  ],
  "text": "class IntegerLessThanOrEqual(IntegerFieldOverflow, LessThanOrEqual)"
}
```
