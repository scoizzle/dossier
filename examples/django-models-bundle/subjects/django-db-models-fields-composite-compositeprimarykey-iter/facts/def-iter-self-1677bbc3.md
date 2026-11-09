# Fact 1677bbc3

Store id: 434d10fc-8587-412c-9467-0d6d45c35bb2

## Text

```text
def __iter__(self)
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
- posted_at: `2026-11-09T23:44:50.4878710+00:00`

## Data

```json
{
  "end_line": 101,
  "entity_kind": "method",
  "parent": "CompositePrimaryKey",
  "start_line": 100,
  "symbol": "CompositePrimaryKey.__iter__"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/fields/composite.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":100,"selector":"L100-L101","symbol":"CompositePrimaryKey.__iter__"}`

## Referenced by

None.

## Subject

[django/db/models/fields/composite::CompositePrimaryKey.__iter__](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 101,
    "entity_kind": "method",
    "parent": "CompositePrimaryKey",
    "start_line": 100,
    "symbol": "CompositePrimaryKey.__iter__"
  },
  "id": "434d10fc-8587-412c-9467-0d6d45c35bb2",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:44:50.4878710+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 100,
        "selector": "L100-L101",
        "symbol": "CompositePrimaryKey.__iter__"
      },
      "rel": "derived_from",
      "target": "django/db/models/fields/composite.py"
    }
  ],
  "status": "live",
  "subject_id": "97c70944-a183-4487-a5b5-55356003686d",
  "subject_name": "django/db/models/fields/composite::CompositePrimaryKey.__iter__",
  "tags": [
    "entity:method"
  ],
  "text": "def __iter__(self)"
}
```
