# Fact e91b82c0

Store id: 922358a3-a40f-41a5-9e63-006173422bb2

## Text

```text
class Round(FixDecimalInputMixin, Transform)
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
- posted_at: `2026-11-09T23:44:53.7615160+00:00`

## Data

```json
{
  "end_line": 194,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 178,
  "symbol": "Round"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":178,"selector":"L178-L194","symbol":"Round"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Round](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 194,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 178,
    "symbol": "Round"
  },
  "id": "922358a3-a40f-41a5-9e63-006173422bb2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7615160+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 178,
        "selector": "L178-L194",
        "symbol": "Round"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "52fa71a0-3a1f-44b4-b322-c0da24d91bd1",
  "subject_name": "django/db/models/functions/math::Round",
  "tags": [
    "entity:class"
  ],
  "text": "class Round(FixDecimalInputMixin, Transform)"
}
```
