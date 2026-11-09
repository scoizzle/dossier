# Fact 7618bacb

Store id: 3032181b-6b94-41e4-945b-59da7150c04c

## Text

```text
class Upper(Transform)
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
- posted_at: `2026-11-09T23:32:02.3209970+00:00`

## Data

```json
{
  "end_line": 377,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 375,
  "symbol": "Upper"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":375,"selector":"L375-L377","symbol":"Upper"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::Upper](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 377,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 375,
    "symbol": "Upper"
  },
  "id": "3032181b-6b94-41e4-945b-59da7150c04c",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:02.3209970+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 375,
        "selector": "L375-L377",
        "symbol": "Upper"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "9e3b84d1-5b04-44e7-a15d-e7691991400a",
  "subject_name": "django/db/models/functions/text::Upper",
  "tags": [
    "entity:class"
  ],
  "text": "class Upper(Transform)"
}
```
