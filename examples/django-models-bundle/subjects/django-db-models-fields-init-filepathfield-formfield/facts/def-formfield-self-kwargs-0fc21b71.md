# Fact 0fc21b71

Store id: a8e25371-fadf-41c1-9e25-f97593c939c5

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
- posted_at: `2026-11-09T23:31:56.6804020+00:00`

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
  "id": "a8e25371-fadf-41c1-9e25-f97593c939c5",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.6804020+00:00"
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
  "subject_id": "cbd72654-772d-46db-80e2-da3eb8972e2f",
  "subject_name": "django/db/models/fields/__init__::FilePathField.formfield",
  "tags": [
    "entity:method"
  ],
  "text": "def formfield(self, **kwargs)"
}
```
