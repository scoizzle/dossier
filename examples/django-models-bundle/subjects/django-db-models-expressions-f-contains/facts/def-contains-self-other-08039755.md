# Fact 08039755

Store id: 7a53325d-cc5f-4c09-b62c-09977e34f0ce

## Text

```text
def __contains__(self, other)
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
- posted_at: `2026-11-09T22:39:41.5600840+00:00`

## Data

```json
{
  "end_line": 903,
  "entity_kind": "method",
  "parent": "F",
  "start_line": 900,
  "symbol": "F.__contains__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":900,"selector":"L900-L903","symbol":"F.__contains__"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::F.__contains__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 903,
    "entity_kind": "method",
    "parent": "F",
    "start_line": 900,
    "symbol": "F.__contains__"
  },
  "id": "7a53325d-cc5f-4c09-b62c-09977e34f0ce",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5600840+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 900,
        "selector": "L900-L903",
        "symbol": "F.__contains__"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "4aab8e17-ee7d-47d9-9d4e-198c09a5cacf",
  "subject_name": "django/db/models/expressions::F.__contains__",
  "tags": [
    "entity:method"
  ],
  "text": "def __contains__(self, other)"
}
```
