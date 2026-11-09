# Fact 2af70e6a

Store id: 723afa03-1d86-4fa2-b9bc-890326387480

## Text

```text
class Power(NumericOutputFieldMixin, Func)
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
- posted_at: `2026-11-09T23:32:01.7324250+00:00`

## Data

```json
{
  "end_line": 143,
  "entity_kind": "class",
  "parent": "math",
  "start_line": 141,
  "symbol": "Power"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/math.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":141,"selector":"L141-L143","symbol":"Power"}`

## Referenced by

None.

## Subject

[django/db/models/functions/math::Power](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 143,
    "entity_kind": "class",
    "parent": "math",
    "start_line": 141,
    "symbol": "Power"
  },
  "id": "723afa03-1d86-4fa2-b9bc-890326387480",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:01.7324250+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 141,
        "selector": "L141-L143",
        "symbol": "Power"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/math.py"
    }
  ],
  "status": "live",
  "subject_id": "01bcbd09-5b52-46e4-917f-a222bd3e668a",
  "subject_name": "django/db/models/functions/math::Power",
  "tags": [
    "entity:class"
  ],
  "text": "class Power(NumericOutputFieldMixin, Func)"
}
```
