# Fact d53f79b0

Store id: a1850a9b-3997-4648-a7af-037cbeebc600

## Text

```text
def _constructor_signature(cls)
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:method`, `decorator:classproperty`, `decorator:functools.lru_cache`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:44:49.4228380+00:00`

## Data

```json
{
  "end_line": 526,
  "entity_kind": "method",
  "parent": "Expression",
  "start_line": 523,
  "symbol": "Expression._constructor_signature"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/expressions.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":523,"selector":"L523-L526","symbol":"Expression._constructor_signature"}`

## Referenced by

None.

## Subject

[django/db/models/expressions::Expression._constructor_signature](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 526,
    "entity_kind": "method",
    "parent": "Expression",
    "start_line": 523,
    "symbol": "Expression._constructor_signature"
  },
  "id": "a1850a9b-3997-4648-a7af-037cbeebc600",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.4228380+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 523,
        "selector": "L523-L526",
        "symbol": "Expression._constructor_signature"
      },
      "rel": "derived_from",
      "target": "django/db/models/expressions.py"
    }
  ],
  "status": "live",
  "subject_id": "035d5c58-35f5-4c0c-b6a0-30bd1d178f0d",
  "subject_name": "django/db/models/expressions::Expression._constructor_signature",
  "tags": [
    "entity:method",
    "decorator:classproperty",
    "decorator:functools.lru_cache"
  ],
  "text": "def _constructor_signature(cls)"
}
```
