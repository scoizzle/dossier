# Fact d1bffc91

Store id: 28ae5c9f-edbb-42e1-bb86-72800f9cf34d

## Text

```text
contains class SQLCompiler
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
- posted_at: `2026-11-09T23:44:57.7715820+00:00`

## Refs

- rel: contains
  - kind: subject
  - target: [django/db/models/sql/compiler::SQLCompiler](../../django-db-models-sql-compiler-sqlcompiler/index.md)
  - basis: observed
  - confidence: none
  - locator: `{"line":42,"symbol":"SQLCompiler"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "id": "28ae5c9f-edbb-42e1-bb86-72800f9cf34d",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.7715820+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "subject",
      "locator": {
        "line": 42,
        "symbol": "SQLCompiler"
      },
      "rel": "contains",
      "target": "3a7f5d2a-e460-4711-8ce2-78af0bd49994"
    }
  ],
  "status": "live",
  "subject_id": "d0d15420-734c-41c7-8915-96b8b2169578",
  "subject_name": "django/db/models/sql/compiler",
  "tags": [
    "entity:class"
  ],
  "text": "contains class SQLCompiler"
}
```
