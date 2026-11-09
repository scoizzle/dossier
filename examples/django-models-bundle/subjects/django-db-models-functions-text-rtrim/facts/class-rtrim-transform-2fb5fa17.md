# Fact 2fb5fa17

Store id: 569a48bb-efbf-4a92-8d25-e6a85b3648b1

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
- posted_at: `2026-11-09T23:44:54.1395010+00:00`

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
  "id": "569a48bb-efbf-4a92-8d25-e6a85b3648b1",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:54.1395010+00:00"
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
  "subject_id": "48d0c801-eaa3-44fa-92f5-34ca18debd06",
  "subject_name": "django/db/models/functions/text::RTrim",
  "tags": [
    "entity:class"
  ],
  "text": "class RTrim(Transform)"
}
```
