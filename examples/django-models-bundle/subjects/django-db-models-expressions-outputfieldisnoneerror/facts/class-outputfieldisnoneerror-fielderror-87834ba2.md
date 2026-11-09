# Fact 87834ba2

Store id: 94ddc451-b4b5-463d-bf5d-902fdc125232

## Text

```text
class OutputFieldIsNoneError(FieldError)
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
- posted_at: `2026-11-09T22:39:41.4967520+00:00`

## Data

```json
{
  "end_line": 171,
  "entity_kind": "class",
  "parent": "expressions",
  "start_line": 170,
  "symbol": "OutputFieldIsNoneError"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":170,"selector":"L170-L171","symbol":"OutputFieldIsNoneError"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::OutputFieldIsNoneError](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 171,
    "entity_kind": "class",
    "parent": "expressions",
    "start_line": 170,
    "symbol": "OutputFieldIsNoneError"
  },
  "id": "94ddc451-b4b5-463d-bf5d-902fdc125232",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.4967520+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 170,
        "selector": "L170-L171",
        "symbol": "OutputFieldIsNoneError"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "3ef98718-74fb-4a7d-b137-1f6a3a5191bd",
  "subject_name": "django/db/models/expressions::OutputFieldIsNoneError",
  "tags": [
    "entity:class"
  ],
  "text": "class OutputFieldIsNoneError(FieldError)"
}
```
