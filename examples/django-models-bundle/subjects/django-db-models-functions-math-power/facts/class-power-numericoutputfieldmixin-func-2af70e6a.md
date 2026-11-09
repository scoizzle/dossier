# Fact 2af70e6a

Store id: 7cc87f75-23c5-41ec-892e-a2f2bbe9c51a

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
- posted_at: `2026-11-09T23:44:53.7438520+00:00`

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
  "id": "7cc87f75-23c5-41ec-892e-a2f2bbe9c51a",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:53.7438520+00:00"
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
  "subject_id": "cde72ab9-4ed3-4b00-b51d-d51429917233",
  "subject_name": "django/db/models/functions/math::Power",
  "tags": [
    "entity:class"
  ],
  "text": "class Power(NumericOutputFieldMixin, Func)"
}
```
