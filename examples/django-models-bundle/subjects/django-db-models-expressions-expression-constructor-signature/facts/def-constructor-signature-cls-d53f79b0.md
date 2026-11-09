# Fact d53f79b0

Store id: 1944a79d-c47f-498b-b9a2-107c910e7d04

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
- posted_at: `2026-11-09T22:39:41.5362220+00:00`

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
  "id": "1944a79d-c47f-498b-b9a2-107c910e7d04",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:41.5362220+00:00"
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
  "subject_id": "382be666-c1fb-450e-b2a5-155db5b3bb29",
  "subject_name": "django/db/models/expressions::Expression._constructor_signature",
  "tags": [
    "entity:method",
    "decorator:classproperty",
    "decorator:functools.lru_cache"
  ],
  "text": "def _constructor_signature(cls)"
}
```
