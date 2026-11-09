# Fact d9203564

Store id: 8edf5cb7-9c0f-4a1a-9f25-fa1d1f3c6457

## Text

```text
def quote_name(self, name)
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
- posted_at: `2026-11-09T23:32:05.7221990+00:00`

## Data

```json
{
  "end_line": 578,
  "entity_kind": "method",
  "parent": "SQLCompiler",
  "start_line": 569,
  "symbol": "SQLCompiler.quote_name"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/sql/compiler.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":569,"selector":"L569-L578","symbol":"SQLCompiler.quote_name"}`

## Items

```json
[
  {
    "text": "A wrapper around connection.ops.quote_name that memoizes quoted name values.",
    "locator": {
      "line": 570
    }
  }
]
```

## Referenced by

None.

## Subject

[django/db/models/sql/compiler::SQLCompiler.quote_name](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 578,
    "entity_kind": "method",
    "parent": "SQLCompiler",
    "start_line": 569,
    "symbol": "SQLCompiler.quote_name"
  },
  "id": "8edf5cb7-9c0f-4a1a-9f25-fa1d1f3c6457",
  "items": [
    {
      "locator": {
        "line": 570
      },
      "text": "A wrapper around connection.ops.quote_name that memoizes quoted name values."
    }
  ],
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:05.7221990+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 569,
        "selector": "L569-L578",
        "symbol": "SQLCompiler.quote_name"
      },
      "rel": "derived_from",
      "target": "django/db/models/sql/compiler.py"
    }
  ],
  "status": "live",
  "subject_id": "57bc578d-d533-4894-9707-4a657dfc52bc",
  "subject_name": "django/db/models/sql/compiler::SQLCompiler.quote_name",
  "tags": [
    "entity:method"
  ],
  "text": "def quote_name(self, name)"
}
```
