# Fact d1bffc91

Store id: abf8f386-22b1-4bae-9ad5-1ae94903e4d0

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
- posted_at: `2026-11-09T23:32:06.1168670+00:00`

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
  "id": "abf8f386-22b1-4bae-9ad5-1ae94903e4d0",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:06.1168670+00:00"
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
      "target": "364ed1da-3c95-47cb-bece-b6b90e73ee88"
    }
  ],
  "status": "live",
  "subject_id": "eec456aa-334a-4312-a193-ed044257811d",
  "subject_name": "django/db/models/sql/compiler",
  "tags": [
    "entity:class"
  ],
  "text": "contains class SQLCompiler"
}
```
