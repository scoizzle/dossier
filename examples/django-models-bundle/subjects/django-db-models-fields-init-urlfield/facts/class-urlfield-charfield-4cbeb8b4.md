# Fact 4cbeb8b4

Store id: 5f7207fe-cbba-461d-9ae5-74c8ad45c42e

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
- posted_at: `2026-11-09T23:31:56.8319850+00:00`

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
  "id": "5f7207fe-cbba-461d-9ae5-74c8ad45c42e",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:31:56.8319850+00:00"
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
  "subject_id": "e58bdd34-ecd1-47fa-b3b3-b6b96ffc801d",
  "subject_name": "django/db/models/fields/__init__::URLField",
  "tags": [
    "entity:class"
  ],
  "text": "class URLField(CharField)"
}
```
