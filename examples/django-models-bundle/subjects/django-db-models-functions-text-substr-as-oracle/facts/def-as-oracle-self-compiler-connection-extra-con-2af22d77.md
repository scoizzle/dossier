# Fact 2af22d77

Store id: e4540cc6-4420-44cf-803f-14148057115f

## Text

```text
def as_oracle(self, compiler, connection, **extra_context)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T22:39:47.2142230+00:00`

## Data

```json
{
  "end_line": 367,
  "entity_kind": "method",
  "parent": "Substr",
  "start_line": 366,
  "symbol": "Substr.as_oracle"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":366,"selector":"L366-L367","symbol":"Substr.as_oracle"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Substr.as_oracle](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 367,
    "entity_kind": "method",
    "parent": "Substr",
    "start_line": 366,
    "symbol": "Substr.as_oracle"
  },
  "id": "e4540cc6-4420-44cf-803f-14148057115f",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.2142230+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 366,
        "selector": "L366-L367",
        "symbol": "Substr.as_oracle"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "706c16ac-fdc4-4c4b-8ff4-c002a6f8898c",
  "subject_name": "django/db/models/functions/text::Substr.as_oracle",
  "tags": [
    "entity:method"
  ],
  "text": "def as_oracle(self, compiler, connection, **extra_context)"
}
```
