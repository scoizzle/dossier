# Fact 2ee99a0e

Store id: 6640f79d-6d8c-4f08-b011-f3f23ed606e3

## Text

```text
def check(self, **kwargs)
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
- posted_at: `2026-11-09T23:44:50.1451940+00:00`

## Data

```json
{
  "end_line": 2046,
  "entity_kind": "method",
  "parent": "FilePathField",
  "start_line": 2042,
  "symbol": "FilePathField.check"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2042,"selector":"L2042-L2046","symbol":"FilePathField.check"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField.check](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2046,
    "entity_kind": "method",
    "parent": "FilePathField",
    "start_line": 2042,
    "symbol": "FilePathField.check"
  },
  "id": "6640f79d-6d8c-4f08-b011-f3f23ed606e3",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.1451940+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2042,
        "selector": "L2042-L2046",
        "symbol": "FilePathField.check"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "17c89784-7d2b-44a1-8c52-3122c09e0a08",
  "subject_name": "django/db/models/fields/__init__::FilePathField.check",
  "tags": [
    "entity:method"
  ],
  "text": "def check(self, **kwargs)"
}
```
