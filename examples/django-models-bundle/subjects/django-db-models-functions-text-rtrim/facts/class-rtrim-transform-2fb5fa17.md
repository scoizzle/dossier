# Fact 2fb5fa17

Store id: 400392dd-df19-4055-8ce6-f5c3e8bcec75

## Text

```text
class RTrim(Transform)
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
- posted_at: `2026-11-09T22:39:47.1712040+00:00`

## Data

```json
{
  "end_line": 299,
  "entity_kind": "class",
  "parent": "text",
  "start_line": 297,
  "symbol": "RTrim"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/functions/text.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":297,"selector":"L297-L299","symbol":"RTrim"}`

## Referenced by

None.

## Subject

[django/db/models/functions/text::RTrim](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 299,
    "entity_kind": "class",
    "parent": "text",
    "start_line": 297,
    "symbol": "RTrim"
  },
  "id": "400392dd-df19-4055-8ce6-f5c3e8bcec75",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:47.1712040+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 297,
        "selector": "L297-L299",
        "symbol": "RTrim"
      },
      "rel": "derived_from",
      "target": "django/db/models/functions/text.py"
    }
  ],
  "status": "live",
  "subject_id": "65cb7c61-610f-45f7-9d33-97ec20a4e0ca",
  "subject_name": "django/db/models/functions/text::RTrim",
  "tags": [
    "entity:class"
  ],
  "text": "class RTrim(Transform)"
}
```
