# Fact 824188b5

Store id: 190f4858-198a-4e73-986e-facac65b1966

## Text

```text
def get_blank_choice_label()
```

## Attributes

- Kind: code
- Status: live
- Confidence: 1
- Tags: `entity:function`

## Provenance

- actor: `dossier-cli`
- actor_type: `tool`
- channel: `cli`
- posted_at: `2026-11-09T23:32:07.9460590+00:00`

## Data

```json
{
  "end_line": 81,
  "entity_kind": "function",
  "parent": "utils",
  "start_line": 74,
  "symbol": "get_blank_choice_label"
}
```

## Refs

- rel: derived_from
  - kind: file
  - target: `django/db/models/utils.py`
  - basis: observed
  - confidence: none
  - locator: `{"line":74,"selector":"L74-L81","symbol":"get_blank_choice_label"}`

## Referenced by

None.

## Subject

[django/db/models/utils::get_blank_choice_label](../index.md)

## Machine record

```json
{
  "attachments": [],
  "confidence": 1,
  "data": {
    "end_line": 81,
    "entity_kind": "function",
    "parent": "utils",
    "start_line": 74,
    "symbol": "get_blank_choice_label"
  },
  "id": "190f4858-198a-4e73-986e-facac65b1966",
  "kind": "code",
  "provenance": {
    "actor": "dossier-cli",
    "actor_type": "tool",
    "channel": "cli",
    "posted_at": "2026-11-09T23:32:07.9460590+00:00"
  },
  "refs": [
    {
      "basis": "observed",
      "kind": "file",
      "locator": {
        "line": 74,
        "selector": "L74-L81",
        "symbol": "get_blank_choice_label"
      },
      "rel": "derived_from",
      "target": "django/db/models/utils.py"
    }
  ],
  "status": "live",
  "subject_id": "eb54e3f6-7df3-4b9b-a5aa-d65a0329e347",
  "subject_name": "django/db/models/utils::get_blank_choice_label",
  "tags": [
    "entity:function"
  ],
  "text": "def get_blank_choice_label()"
}
```
