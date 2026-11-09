# Fact 916ff304

Store id: b0efb94e-df46-40ef-811a-85e624577997

## Text

```text
def __eq__(self, other)
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
- posted_at: `2026-11-09T22:39:48.0354420+00:00`

## Data

```json
{
  "end_line": 179,
  "entity_kind": "method",
  "parent": "Lookup",
  "start_line": 176,
  "symbol": "Lookup.__eq__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/lookups.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":176,"selector":"L176-L179","symbol":"Lookup.__eq__"}`

## Referenced by

None.

## Subject

[django/db/models/lookups::Lookup.__eq__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 179,
    "entity_kind": "method",
    "parent": "Lookup",
    "start_line": 176,
    "symbol": "Lookup.__eq__"
  },
  "id": "b0efb94e-df46-40ef-811a-85e624577997",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T22:39:48.0354420+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 176,
        "selector": "L176-L179",
        "symbol": "Lookup.__eq__"
      },
      "rel": "derived_from",
      "target": "django/db/models/lookups.py"
    }
  ],
  "status": "live",
  "subject_id": "dd9778cb-fb7f-4738-9532-9f20c5515feb",
  "subject_name": "django/db/models/lookups::Lookup.__eq__",
  "tags": [
    "entity:method"
  ],
  "text": "def __eq__(self, other)"
}
```
