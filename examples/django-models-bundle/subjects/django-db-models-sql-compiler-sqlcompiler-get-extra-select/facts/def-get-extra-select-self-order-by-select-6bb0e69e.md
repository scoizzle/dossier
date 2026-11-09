# Fact 6bb0e69e

Store id: 56774684-2342-4417-b901-1bf703bff51e

## Text

```text
def get_extra_select(self, order_by, select)
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
- posted_at: `2026-11-09T23:44:57.4683240+00:00`

## Data

```json
{
  "end_line": 567,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 559,
  "symbol": "SQLCompiler.get_extra_select"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":559,"selector":"L559-L567","symbol":"SQLCompiler.get_extra_select"}`

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.get_extra_select](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 567,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 559,
    "symbol": "SQLCompiler.get_extra_select"
  },
  "id": "56774684-2342-4417-b901-1bf703bff51e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:57.4683240+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 559,
        "selector": "L559-L567",
        "symbol": "SQLCompiler.get_extra_select"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "5f0793a2-2373-431b-ba2a-70363679f333",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.get_extra_select",
  "tags": [
    "entity:method"
  ],
  "text": "def get_extra_select(self, order_by, select)"
}
```
