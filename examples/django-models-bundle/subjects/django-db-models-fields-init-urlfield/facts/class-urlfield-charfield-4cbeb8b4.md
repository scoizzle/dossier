# Fact 4cbeb8b4

Store id: df284377-baf3-41e7-b875-944eebca522b

## Text

```text
class URLField(CharField)
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
- posted_at: `2026-11-09T22:39:42.6796010+00:00`

## Data

```json
{
  "end_line": 2741,
  "entity_kind": "class",
  "parent": "__init__",
  "start_line": 2719,
  "symbol": "URLField"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":2719,"selector":"L2719-L2741","symbol":"URLField"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::URLField](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 2741,
    "entity_kind": "class",
    "parent": "__init__",
    "start_line": 2719,
    "symbol": "URLField"
  },
  "id": "df284377-baf3-41e7-b875-944eebca522b",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:42.6796010+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 2719,
        "selector": "L2719-L2741",
        "symbol": "URLField"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "92219de1-b0f8-4018-a780-b1f829ad800d",
  "subject_name": "django/db/models/fields/__init__::URLField",
  "tags": [
    "entity:class"
  ],
  "text": "class URLField(CharField)"
}
```
