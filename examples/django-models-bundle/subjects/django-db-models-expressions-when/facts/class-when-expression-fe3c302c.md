# Fact fe3c302c

Store id: 84bb9687-0730-446d-8409-7c66b4c0b7a9

## Text

```text
class When(Expression)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:class`, `decorator:deconstructible`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:41.6884210+00:00`

## Data

```json
{
  "end_line": 1713,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 1635,
  "symbol": "When"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":1635,"selector":"L1635-L1713","symbol":"When"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::When](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 1713,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 1635,
    "symbol": "When"
  },
  "id": "84bb9687-0730-446d-8409-7c66b4c0b7a9",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.6884210+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 1635,
        "selector": "L1635-L1713",
        "symbol": "When"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "16e5a540-bc35-4ace-8815-abd783b9ac7a",
  "subject_name": "django/db/models/expressions::When",
  "tags": [
    "entity:class",
    "decorator:deconstructible"
  ],
  "text": "class When(Expression)"
}
```
