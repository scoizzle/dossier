# Fact 5a9f5753

Store id: 9159b02f-8070-473d-a835-98b225edc895

## Text

```text
def _description(self)
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
- posted_at: `2026-11-09T23:44:49.9562300+00:00`

## Data

```json
{
  "end_line": 189,
  "entity_kind": "method",
  "parent": "Field",
  "start_line": 186,
  "symbol": "Field._description"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/__init__.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":186,"selector":"L186-L189","symbol":"Field._description"}`

## Referenced by

None.

## Subject

[django/db/models/fields/__init__::Field._description](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 189,
    "entity_kind": "method",
    "parent": "Field",
    "start_line": 186,
    "symbol": "Field._description"
  },
  "id": "9159b02f-8070-473d-a835-98b225edc895",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:49.9562300+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 186,
        "selector": "L186-L189",
        "symbol": "Field._description"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/__init__.py"
    }
  ],
  "status": "live",
  "subject_id": "99f13dca-352b-4743-b857-d6a822d45ea3",
  "subject_name": "django/db/models/fields/__init__::Field._description",
  "tags": [
    "entity:method"
  ],
  "text": "def _description(self)"
}
```
