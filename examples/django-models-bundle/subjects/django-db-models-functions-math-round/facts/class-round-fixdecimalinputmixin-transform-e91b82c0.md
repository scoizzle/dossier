# Fact e91b82c0

Store id: 72f1b3c5-4d67-43bc-b1e0-b27990d79e12

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
- posted_at: `2026-11-09T22:39:46.6684100+00:00`

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
  "id": "72f1b3c5-4d67-43bc-b1e0-b27990d79e12",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:46.6684100+00:00"
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
  "subject_id": "077cfbf1-2b44-41fa-8b10-2e40a42cd963",
  "subject_name": "django/db/models/functions/math::Round",
  "tags": [
    "entity:class"
  ],
  "text": "class Round(FixDecimalInputMixin, Transform)"
}
```
