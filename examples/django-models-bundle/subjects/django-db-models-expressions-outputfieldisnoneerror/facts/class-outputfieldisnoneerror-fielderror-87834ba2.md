# Fact 87834ba2

Store id: 6e159dc0-0f21-4bb6-a1e3-6f71a621a6cd

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
- posted_at: `2026-11-09T23:31:55.7552960+00:00`

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
  "id": "6e159dc0-0f21-4bb6-a1e3-6f71a621a6cd",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:55.7552960+00:00"
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
  "subject_id": "0b23cf0c-c438-4417-bf8f-3b464120954b",
  "subject_name": "django/db/models/expressions::OutputFieldIsNoneError",
  "tags": [
    "entity:class"
  ],
  "text": "class OutputFieldIsNoneError(FieldError)"
}
```
