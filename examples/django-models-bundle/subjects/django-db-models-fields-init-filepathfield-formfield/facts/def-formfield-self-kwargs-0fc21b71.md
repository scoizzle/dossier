# Fact 0fc21b71

Store id: 3e490635-7ee3-458d-829a-281f56aa87f4

## Text

```text
def formfield(self, **kwargs)
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
- posted_at: `2026-11-09T22:39:42.5147660+00:00`

## Data

```json
{
  "end_line": 2093,
  "entity_kind": "method",
  "parent": "FilePathField",
  "start_line": 2082,
  "symbol": "FilePathField.formfield"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2082,"selector":"L2082-L2093","symbol":"FilePathField.formfield"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::FilePathField.formfield](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2093,
    "entity_kind": "method",
    "parent": "FilePathField",
    "start_line": 2082,
    "symbol": "FilePathField.formfield"
  },
  "id": "3e490635-7ee3-458d-829a-281f56aa87f4",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.5147660+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2082,
        "selector": "L2082-L2093",
        "symbol": "FilePathField.formfield"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "3c41842d-6478-492b-9cbb-7b3ab93539b6",
  "subject_name": "django/db/models/fields/__init__::FilePathField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
